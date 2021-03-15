using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

using Microsoft.CodeAnalysis.MSBuild;

namespace VNC.CodeAnalysis.Workspace
{

    public static class Helper
    {
        private static int CLASS_BASE_ERRORNUMBER = ErrorNumbers.HELPER;
        //private const string LOG_APPNAME = ErrorNumbers.CLASSNAME;

        public static List<String> GetSourceFilesToProcessFromConfigFile(string configFileFullPath, string branchName, string solutionName, string projectName)
        {
            long startTicks = Log.Trace(string.Format("configFileFullPath:({0})", configFileFullPath), Common.LOG_APPNAME);

            List<String> filesToProcess = null;
            string sourcePath = string.Empty;
            string projectFolderPath = string.Empty;
            string projectFileName = string.Empty;

            // This  method returns a list of files to process.
            //
            // If a VS ProjectFile is available, use it to get the list of files
            // Otherwise return the files specified in the <SourceFile /> elements

            XElement configFileElement = XElement.Load(new Uri(configFileFullPath).ToString());
            XElement branchElement = configFileElement.Descendants("Branch").Where(attr => attr.Attribute("Name").Value == branchName).First();

            if (branchElement != null)
            {
                sourcePath = branchElement.Attribute("SourcePath").Value;

                // TODO(crhodes)
                // Add some validation         
            }

            XElement solutionElement = branchElement.Descendants("Solution").Where(attr => attr.Attribute("Name").Value == solutionName).First();
            XElement projectElement = solutionElement.Descendants("Project").Where(attr => attr.Attribute("Name").Value == projectName).First();

            if (projectElement != null)
            {
                projectFolderPath = projectElement.Attribute("FolderPath").Value;
                projectFileName = projectElement.Attribute("FileName").Value;
            }

            if (projectFileName.Length > 0)
            {
                // TODO(crhodes)
                // Verify the project file exists.  
                // If so, open it and get the list of files.
                filesToProcess = GetSourceFilesToProcessFromVSProject(sourcePath + "\\" + projectFolderPath + "\\" + projectFileName);
            }
            else
            {
                filesToProcess = new List<string>();

                string projectBasePath = sourcePath + "\\" + projectFolderPath + "\\";

                foreach (XElement sourceFile in projectElement.Descendants("SourceFile"))
                {
                    string sourceFolderPath = sourceFile.Attribute("FolderPath").Value;

                    if (sourceFolderPath.Length > 0)
                    {
                        sourceFolderPath += "\\";
                    }

                    string sourceFullPath = projectBasePath + sourceFolderPath + sourceFile.Attribute("FileName").Value;

                    if (File.Exists(sourceFullPath))
                    {
                        filesToProcess.Add(sourceFullPath);
                    }
                    else
                    {                      
                        // TODO(crhodes)
                        // Handle errors.

                        //FileInfo fileInfo = new FileInfo(filePath);

                        //if (!Directory.Exists(fileInfo.DirectoryName))
                        //{
                        //    MessageBox.Show(string.Format("Directory\n\n{0}\n\ndoes not exist", fileInfo.DirectoryName), "Check Path or Config File");
                        //}
                        //else
                        //{
                        //    MessageBox.Show(string.Format("File\n\n{0}\nin\n\n{1}\n\ndoes not exist", fileInfo.Name, fileInfo.DirectoryName), "Check Path or Config File");
                        //}
                    }
                }
            }

            return filesToProcess;
        }

        public static List<String> GetSourceFilesToProcessFromVSProject(string projectFullPath)
        {
            long startTicks = Log.Trace(string.Format("projectFullPath:({0})", projectFullPath), Common.LOG_APPNAME);

            List<String> filesToProcess = new List<string>();


            // This  method returns a list of files to process.

            // If a ProjectFile is available, use it to get the list of files
            // Otherwise return the files selected in cbeSourceFiles.


            try
            {
                using (var workSpace = MSBuildWorkspace.Create())
                {
                    var project = workSpace.OpenProjectAsync(projectFullPath).Result;

                    //Microsoft.CodeAnalysis.Project project = null;

                    //Task.Run(async () => project = await workSpace.OpenProjectAsync(projectFullPath));

                    FileInfo fileInfo = new FileInfo(projectFullPath);

                    switch (fileInfo.Extension)
                    {
                        case ".csproj":
                            AddSourceFilesFromCSProject(filesToProcess, project);
                            break;

                        case ".vbproj":
                            AddSourceFilesFromVBProject(filesToProcess, project);
                            break;

                        default:
                            // TODO(crhodes)
                            // How to handle unsupported project types
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, Common.LOG_APPNAME);
            }

            Log.Trace(string.Format("Exit: Count({0})", filesToProcess.Count), Common.LOG_APPNAME, startTicks);

            return filesToProcess;
        }

        public static void AddSourceFilesFromVBProject(List<string> filesToProcess, Microsoft.CodeAnalysis.Project project)
        {
            long startTicks = Log.Trace1(string.Format("Enter: project.Path:({0})", project.FilePath), Common.LOG_APPNAME);

            // This did not return files until Microsoft.Build.Tasks.Core was added
            // https://github.com/dotnet/roslyn/issues/25370

            foreach (var document in project.Documents)
            {
                string filePath = document.FilePath;

                // Skip a few files

                if (filePath.ToLower().Contains("designer"))
                {
                    continue;
                }

                if (filePath.Contains("My Project"))
                {
                    continue;
                }

                if (document.Name == "AssemblyInfo.vb")
                {
                    continue;
                }

                // Add everything else

                if (document.Name.EndsWith(".vb"))
                {
                    filesToProcess.Add(filePath);
                }
            }

            Log.Trace(string.Format("Exit: Count({0})", filesToProcess.Count), Common.LOG_APPNAME, startTicks);
        }

        public static void AddSourceFilesFromCSProject(List<string> filesToProcess, Microsoft.CodeAnalysis.Project project)
        {
            Log.Trace1(string.Format("Enter: project.Path:({0})", project.FilePath), Common.LOG_APPNAME);

            foreach (var document in project.Documents)
            {
                string filePath = document.FilePath;

                // Skip a few files

                if (filePath.ToLower().Contains("designer"))
                {
                    continue;
                }

                if (document.Name == "AssemblyInfo.cs")
                {
                    continue;
                }

                // Add everything else

                if (document.Name.EndsWith(".cs"))
                {
                    filesToProcess.Add(filePath);
                }
            }

            Log.Trace(string.Format("Exit: Count({0})", filesToProcess.Count), Common.LOG_APPNAME);
        }
    }
}
