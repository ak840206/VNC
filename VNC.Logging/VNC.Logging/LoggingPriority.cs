namespace VNC
{
	public enum LoggingPriority : int
    {
		// Some priorities have been used consistently and are named for easier use.
		// Keep this in sync with LogNamed.tt named_methods

		APPLICATION_START = 100,
		APPLICATION_END = 100,
		LOADEASE = 100,

		SQL_CALL = 1002,

		PAGE_LOAD = 10000,
		FORM_LOAD = 10000,

		EVENT_HANDLER = 10001,
        EVENT = 10021,

		DIAGNOSTIC = 10001,

		STATUS = 10002,
        APPLICATION_INITIALIZE = 10002,

		REDIRECT_TRANSFER = 10003,

		POLLING = 10004,

		ERROR_TRACE = 10005,
		ERROR_TRACE_LOW = 10015,

		EASESYS_IO = 10006,
		EASESYS_IO_MED = 10016,
		EASESYS_IO_LOW = 10026,

        INFRASTRUCTURE = 10016,

		SYNTAX = 10016,

		UI_CONTROL = 10007,
		UI_CONTROL_MED = 10017,
		UI_CONTROL_LOW = 10027,

        PRESENTATION = 10007,
        VIEW = 10017,
        VIEW_LOW = 10027,

		BINDER = 10017,

		UTILITY = 10008,
		UTILITY_MED = 10018,
		UTILITY_LOW = 10028,
        VIEWMODEL = 10018,
        VIEWMODEL_LOW = 10028,

		OPERATION = 10009,
		OPERATION_LOW = 10019,
        CORE = 10009,
        MODULE = 10019,
        MODULE_INITIALIZE = 10029,

		APPLICATION_SESSION = 10010,
		APPLICATION_SESSION_LOW = 10020,

        APPLICATION = 10010,
        APPLICATIONSERVICES = 10020,

		LEXER = 10020,

		SYSTEM_CONFIG = 10011,
		SYSTEM_CONFIG_LOW = 10021,

		EVALUATOR = 10021,

		FILE_DIR_IO = 10012,
		FILE_DIR_IO_LOW = 10022,

        DOMAIN = 10012,
        DOMAINSERVICES = 10022,

		PARSER = 10012,

		DATABASE_IO = 10013,
		DATABASE_IO_LOW = 10023,

        PERSISTENCE = 10013,
        PERSISTENCE_LOW = 10023,

		COMPILER = 10013,

		SECURITY = 10014,
		SECURITY_LOW = 10024,

		DEFAULT = 10019,

		CLEAR_INITIALIZE = 10025,
        CONSTRUCTOR = 10025,

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
		Trace30		= 10030,
		Max			= 10030
    }
}