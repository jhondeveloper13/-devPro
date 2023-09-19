Dev.Pro: Test Task
Jônatas Xavier
1.	Normal Logging:
•	Input: log_message("test.log", "Normal message", "INFO")
•	Expected Output in test.log:  [2023-04-24 12:34:56] [INFO] Normal message 
2.	Warning Logging:
•	Input: log_message("test.log", "Warning message", "WARNING")
•	Expected Output in test.log:  [2023-04-24 12:35:10] [WARNING] Warning message 
3.	Error Logging:
•	Input: log_message("test.log", "Error message", "ERROR")
•	Expected Output in test.log: [2023-04-24 12:35:30] [ERROR] Error message 
4.	Invalid Log Level:
•	Input: log_message("test.log", "Invalid message", "INVALID")
•	Expected Output: Invalid log level: INVALID
5.	Empty Message:
•	Input: log_message("test.log", "", "INFO")
•	Expected Output: Message cannot be empty
6.	Empty Log File:
•	Input: log_message ("empty.log", "Info message", "INFO") log_message("empty.log", "Warning message", "WARNING") 
•	Expected Output in empty.log:  [2023-04-24 12:34:56] [INFO] Info message [2023-04-24 12:35:10] [WARNING] Warning message 

Scenario Outline: Validate Type Logs
Given that I am receiving events and errors from the System
When a <typeLog> occurs
So format validation for <typeLog> is “true”

Exemples:
|typeLog|
| “Normal Logging”  |
| “Warning Logging” |
| “Error Logging”        |
| “Invalid Log Level” |
| “Empty Message”  |
| “Empty Log File”     |


