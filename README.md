# TimeSheetApplication
This project is a simple time tracking application built using ASP.NET MVC (C#) to facilitate clock-in and clock-out functionalities for users. The application allows users to register, log their working hours, and view their time entries.

Features =>
User Registration: New users can register themselves to start tracking their time entries.
Clock In/Out: Users can log their work hours by clocking in and out using dedicated buttons.
Time Entry Management: Users can view their logged time entries.

Technologies Used =>
ASP.NET MVC (C#),
Json (For database purpose),
NUnit (for unit testing),
Moq (for mocking dependencies in tests)

Project Structure =>
Controllers: Contains the main controllers for handling user actions.
Models: Defines the data models used in the application.
Views: Contains the UI components and Razor views.

How to Use =>
Register as a new user to start using the time tracking functionality.
Click "Clock In", enter your username and clock in to start tracking time and the same applies to the "Clock Out" to stop.
Navigate from the landing page-view staff entries and input your username to view your time entries.

Unit tests are available in the TimesheetApplication.Tests project.
Use a test runner (e.g., NUnit Test Adapter in Visual Studio) to execute tests.
