```javascript
class Account {
    constructor(accountNumber, balance) {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    deposit(amount) {
        this.balance += amount;
    }

    withdraw(amount) {
        if (amount > this.balance) {
            console.log('Insufficient balance');
            return;
        }
        this.balance -= amount;
    }

    calculateInterest(rate) {
        return this.balance * rate / 100;
    }

    display() {
        console.log(`Account Number: ${this.accountNumber}, Balance: ${this.balance}`);
    }
}

class Bank {
    constructor() {
        this.accounts = [];
    }

    createAccount(accountNumber, initialDeposit) {
        let account = new Account(accountNumber, initialDeposit);
        this.accounts.push(account);
    }

    findAccount(accountNumber) {
        for (let account of this.accounts) {
            if (account.accountNumber === accountNumber) {
                return account;
            }
        }
        return null;
    }

    deposit(accountNumber, amount) {
        let account = this.findAccount(accountNumber);
        if (account === null) {
            console.log('Account not found');
            return;
        }
        account.deposit(amount);
    }

    withdraw(accountNumber, amount) {
        let account = this.findAccount(accountNumber);
        if (account === null) {
            console.log('Account not found');
            return;
        }
        account.withdraw(amount);
    }

    calculateInterest(accountNumber, rate) {
        let account = this.findAccount(accountNumber);
        if (account === null) {
            console.log('Account not found');
            return;
        }
        let interest = account.calculateInterest(rate);
        console.log(`Interest for account ${accountNumber} is ${interest}`);
    }

    displayAccounts() {
        for (let account of this.accounts) {
            account.display();
        }
    }
}

let bank = new Bank();
bank.createAccount(123, 1000);
bank.createAccount(456, 2000);
bank.deposit(123, 500);
bank.withdraw(456, 1000);
bank.calculateInterest(123, 5);
bank.displayAccounts();
```