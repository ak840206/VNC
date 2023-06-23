namespace VNC
{
	// Some priorities have been used consistently and are named for easier use.
	// Keep this in sync with LogNamed.tt named_methods

	public enum LoggingPriority : int
    {
		#region  These came from EASE days

		APPLICATION_START = 100,
		APPLICATION_END = 100,
		LOADEASE = 100,

		SQL_CALL = 1002,

		PAGE_LOAD = 10000,
		FORM_LOAD = 10000,

		// EVENT_HANDLER = 10001, - Use Architecture Below

		STATUS = 10002,

		REDIRECT_TRANSFER = 10003,

		POLLING = 10004,

		ERROR_TRACE = 10005,
		ERROR_TRACE_LOW = 10015,

		EASESYS_IO = 10006,
		EASESYS_IO_MED = 10016,
		EASESYS_IO_LOW = 10026,

		UI_CONTROL = 10007,
		UI_CONTROL_MED = 10017,
		UI_CONTROL_LOW = 10027,

		UTILITY = 10008,
		UTILITY_MED = 10018,
		UTILITY_LOW = 10028,

		OPERATION = 10009,
		OPERATION_LOW = 10019,

		APPLICATION_SESSION = 10010,
		APPLICATION_SESSION_LOW = 10020,

		SYSTEM_CONFIG = 10011,
		SYSTEM_CONFIG_LOW = 10021,

		FILE_DIR_IO = 10012,
		FILE_DIR_IO_LOW = 10022,

		DATABASE_IO = 10013,
		DATABASE_IO_LOW = 10023,

		SECURITY = 10014,
		SECURITY_LOW = 10024,

		CLEAR_INITIALIZE = 10025,

		#endregion

		#region These are from Architecture visualization

		CONSTRUCTOR = 9000,
		EVENT = 9001,
		EVENT_HANDLER = 9002,
		APPLICATION_INITIALIZE = 9003,
        CORE = 9004,
        MODULE = 9005,
        MODULE_INITIALIZE = 9006,

        APPLICATION = 9007,
        APPLICATIONSERVICES = 9008,
        DOMAIN = 9009,
        DOMAINSERVICES = 9010,

        PERSISTENCE = 9011,
        PERSISTENCE_LOW = 9012,

		INFRASTRUCTURE = 9013,

        PRESENTATION = 9014,
        VIEW = 9015,
        VIEW_LOW = 9016,
        VIEWMODEL = 9017,
        VIEWMODEL_LOW = 9018,

		#endregion

		#region These came from Minsk days

		COMPILER = 10000,
		DIAGNOSTIC = 10001,

		TEST = 10002,

		SYNTAX = 10010,
		SYNTAX_LOW = 10020,
		LEXER = 10011,
		LEXER_LOW = 10021,
		PARSER = 10012,
		PARSER_LOW = 10022,
		BINDER = 10013,
		BINDER_LOW = 10023,
		EVALUATOR = 10014,
		TEXT = 10015,
		TEXT_LOW = 10025,

		#endregion
	
		DEFAULT = 10019,

		// Below are the standard levels

        Failure		= -10,
        Error		= -1,
        Warning		= 1,

        Info		= 100,
        Info1		= 101,
        Info2		= 102,
        Info3		= 103,
        Info4		= 104,
        Info5		= 105,

        Debug		= 1000,
		Debug1		= 1001,
		Debug2		= 1002,
		Debug3		= 1003,
		Debug4		= 1004,
		Debug5		= 1005,

        Arch		= 9000,
		Arch1		= 9001,
		Arch2		= 9002,
		Arch3		= 9003,
		Arch4		= 9004,
		Arch5		= 9005,
		Arch6		= 9006,
		Arch7		= 9007,
		Arch8		= 9008,
		Arch9		= 9009,
		Arch10		= 9010,
		Arch11		= 9011,
		Arch12		= 9012,
		Arch13		= 9013,
		Arch14		= 9014,
		Arch15		= 9015,
		Arch16		= 9016,
		Arch17		= 9017,
		Arch18		= 9018,
		Arch19		= 9019,

        Trace		= 10000,
		Trace1		= 10001,
		Trace2		= 10002,
		Trace3		= 10003,
		Trace4		= 10004,
		Trace5		= 10005,
		Trace6		= 10006,
		Trace7		= 10007,
		Trace8		= 10008,
		Trace9		= 10009,
		Trace10		= 10010,
		Trace11		= 10011,
		Trace12		= 10012,
		Trace13		= 10013,
		Trace14		= 10014,
		Trace15		= 10015,
		Trace16		= 10016,
		Trace17		= 10017,
		Trace18		= 10018,
		Trace19		= 10019,
		Trace20		= 10020,
		Trace21		= 10021,
		Trace22		= 10022,
		Trace23		= 10023,
		Trace24		= 10024,
		Trace25		= 10025,
		Trace26		= 10026,
		Trace27		= 10027,
		Trace28		= 10028,
		Trace29		= 10029,
		Max			= 10030
    }
}