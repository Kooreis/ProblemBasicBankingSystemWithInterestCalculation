# Question: How do you simulate a basic banking system with support for interest calculation? JavaScript Summary

The provided JavaScript code simulates a basic banking system with support for interest calculation. It defines two classes: Account and Bank. The Account class represents a bank account with properties for account number and balance. It has methods for depositing and withdrawing money, calculating interest based on a given rate, and displaying account details. The Bank class represents a bank with an array of accounts. It has methods for creating an account with an initial deposit, finding an account by its number, depositing and withdrawing money from an account, calculating interest for an account, and displaying all accounts. The Bank class uses the methods of the Account class to perform operations on accounts. The code then creates a Bank object, creates two accounts, deposits money into one account, withdraws money from another account, calculates interest for one account, and displays all accounts. This way, the code simulates a basic banking system with support for interest calculation.

---

# TypeScript Differences

The TypeScript version of the solution introduces a few changes compared to the JavaScript version:

1. Type Annotations: TypeScript introduces static types, which are not present in JavaScript. In the TypeScript version, we can see type annotations for variables and function return types. For example, the `balance` and `interestRate` variables in the `Account` class are explicitly declared as `number`. Similarly, the `deposit`, `withdraw`, and `calculateInterest` methods are declared to return `void`, and the `getBalance` method is declared to return `number`.

2. Access Modifiers: TypeScript supports access modifiers (`public`, `private`, and `protected`), which are not available in JavaScript. In the TypeScript version, `balance` and `interestRate` are declared as `private`, meaning they can't be accessed or modified directly from outside the class.

3. Interest Rate: In the TypeScript version, the interest rate is stored as a property of each account, whereas in the JavaScript version, the interest rate is passed as an argument to the `calculateInterest` method.

4. Simplified Banking System: The TypeScript version simplifies the banking system by removing the `Bank` class and the account number concept. It focuses on the operations of a single account.

5. Error Handling: In the JavaScript version, if a withdrawal amount is greater than the account balance, a message is logged and the function returns early. In the TypeScript version, the withdrawal only occurs if the balance is sufficient, otherwise, a message is logged.

6. Interest Calculation: In the TypeScript version, the `calculateInterest` method directly adds the calculated interest to the balance. In the JavaScript version, the `calculateInterest` method returns the calculated interest but does not add it to the balance.

7. Balance Access: In the TypeScript version, the balance is accessed using a getter method `getBalance()`. In the JavaScript version, the balance is displayed using the `display` method in the `Account` class.

---

# C++ Differences

The JavaScript and C++ versions of the banking system are quite similar in terms of functionality. They both have classes for Account and Bank, and methods for depositing, withdrawing, and calculating interest. However, there are some differences due to the language features and methods used in each version.

1. Data Types: In JavaScript, the account number is treated as a number, while in C++, it is treated as a string. This is because JavaScript automatically converts between strings and numbers as needed, while C++ requires explicit conversion.

2. Data Structures: In JavaScript, the accounts are stored in an array, and the findAccount method uses a for-of loop to iterate over the array and find the account with the given account number. In C++, the accounts are stored in a map (an associative container that contains key-value pairs), and the account with a given id can be accessed directly using the id as the key.

3. Error Handling: In JavaScript, if an operation cannot be performed (e.g., withdrawing more than the balance), a message is logged to the console. In C++, a message is printed to the standard output.

4. Interest Calculation: In JavaScript, the interest rate is passed as a parameter to the calculateInterest method, and the interest is calculated as balance * rate / 100. In C++, each account has an interestRate property, and the addInterest method increases the balance by balance * interestRate.

5. Displaying Information: In JavaScript, the display method logs the account number and balance to the console, and the Bank class has a displayAccounts method that displays all accounts. In C++, the Account class does not have a method for displaying information, but the Bank class has a getBalance method that returns the balance of a given account, and the main function prints the balance to the standard output.

6. Object Creation: In JavaScript, new objects are created using the new keyword. In C++, objects are created without the new keyword, and they are automatically destroyed when they go out of scope.

7. Inclusion of Libraries: In C++, the iostream, string, and map libraries are included at the beginning of the program. JavaScript does not require the inclusion of libraries for the features used in this program.

---
