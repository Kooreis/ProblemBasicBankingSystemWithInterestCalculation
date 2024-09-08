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