# Banking System

A C# object-oriented banking system that manages users, bank accounts, and card transactions.

## 📋 Project Overview

This banking system implements a comprehensive solution for managing bank accounts, different types of cards (Credit and Debit), and transactions. The system is built using C# and follows object-oriented programming principles.

## 🏗️ Architecture

The system is composed of several key components:

### Core Classes

- **User**
  - Manages user information (username, password, first name, last name)
  - Handles multiple bank accounts
  - Provides account management functionality

- **BankAccount**
  - Stores bank account details (number and name)
  - Links to associated cards
  - Provides information retrieval methods

- **Card (Abstract Class)**
  - Base class for all card types
  - Manages common card properties (name, type, number)
  - Defines abstract method for printing details

### Card Types

- **Credit Card**
  - Extends Card class
  - Manages credit-specific properties:
    - Monthly payment
    - Card limit
    - Amount used

- **Debit Card**
  - Extends Card class
  - Manages debit-specific properties:
    - Money amount (balance)

### Transaction System

- **Transaction**
  - Handles different types of transfers
  - Manages transaction details:
    - Amount
    - Source and destination
    - Card used

### Enums

- **CardType**
  - Mastercard
  - Visa

- **TransferType**
  - Income
  - Expenses
  - Transfer

## 🔧 Features

- User account management
- Multiple bank account support
- Dual card type system (Credit/Debit)
- Transaction processing
- Account balance tracking
- Card information management
- Secure user authentication

## 💻 Technical Implementation

### Class Relationships

- Users can have multiple bank accounts (1:many)
- Bank accounts can have multiple cards (1:many)
- Transactions are linked to specific cards (1:1)
- Cards are either Credit or Debit type (inheritance)

### Security Features

- Password protection for user accounts
- Encapsulated private fields
- Getter/setter property implementation
- Read-only collections where appropriate

## 🚀 Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- Visual Studio 2022 or compatible IDE

### Building the Project

```bash
dotnet build
```

### Running the Project

```bash
dotnet run
```

### Running Tests

```bash
dotnet test
```

## 📝 Usage Examples

```csharp
// Create a new user
User user = new User("john_doe", "password123", "John", "Doe");

// Create a bank account
BankAccount account = new BankAccount(1001, "Savings Account");

// Add account to user
user.AddAccount(account);

// Create a debit card
Debit debitCard = new Debit("John Doe", CardType.Visa, 123456789, 1000.0f);

// Create a transaction
Transaction transaction = new Transaction(
    TransferType.Transfer,
    500,
    "Account A",
    "Account B",
    debitCard
);
```

## 🔍 Testing

The project includes NUnit testing support with the following packages:
- Microsoft.NET.Test.Sdk
- NUnit
- NUnit.Console
- NUnit3TestAdapter

## 📦 Dependencies

- .NET 6.0
- NUnit (for testing)


