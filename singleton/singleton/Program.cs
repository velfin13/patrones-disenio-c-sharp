using singleton;

EventLogger logger = EventLogger.GetInstance();

logger.LogEvent("Start Events");

EventLogger logger2 = EventLogger.GetInstance();

logger2.LogEvent("generar eventos");

EventLogger logger3 = EventLogger.GetInstance();

logger3.LogEvent("finalizo eventos");
logger3.LogEvent("Ending app");

logger3.DisplayLogs();
