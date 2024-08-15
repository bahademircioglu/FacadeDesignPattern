# Facade Design Pattern Example

This repository contains an example implementation of the Facade design pattern in C#. 
The example demonstrates a simple scenario of checking a customer's eligibility for a loan by interacting with multiple subsystems: Account Information, Credit Score, and Existing Loans.

Project Structure

Program.cs: The entry point of the application. It creates a Kredi (Credit) facade object and uses it to determine if a customer is eligible for a loan.
Musteri.cs: Represents the customer requesting a loan.
HesapBilgisi.cs: Represents the subsystem that checks if the customer has sufficient savings.
KrediSkoru.cs: Represents the subsystem that checks the customer's credit score.
KredilerininDurumu.cs: Represents the subsystem that checks the status of the customer's existing loans.
Kredi.cs: The Facade class that simplifies the interaction with the above subsystems.

Usage

Clone the repository.
Open the solution in your preferred C# IDE (e.g., Visual Studio).
Build and run the project.

How It Works

A Musteri (Customer) object is created with a name.
The Kredi (Credit) facade object is used to check if the customer is eligible for a loan of a specified amount.
The result of the loan eligibility check is displayed in the console, indicating whether the loan request was approved or rejected.

Example Output

Baha Demircioğlu has applied for a loan of up to 125000. The application will be processed based on the following checks:

Checking Baha Demircioğlu's account information...
Checking Baha Demircioğlu's existing loans...
Checking Baha Demircioğlu's credit score...

Baha Demircioğlu's loan request has been approved!
