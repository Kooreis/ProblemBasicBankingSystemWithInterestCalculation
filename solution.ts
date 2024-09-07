```typescript
class Account {
    private balance: number;
    private interestRate: number;

    constructor(balance: number, interestRate: number) {
        this.balance = balance;
        this.interestRate = interestRate;
    }

    deposit(amount: number): void {
        this.balance += amount;
    }

    withdraw(amount: number): void {
        if (this.balance >= amount) {
            this.balance -= amount;
        } else {
            console.log("Insufficient balance");
        }
    }

    calculateInterest(): void {
        this.balance += this.balance * this.interestRate;
    }

    getBalance(): number {
        return this.balance;
    }
}

let account = new Account(1000, 0.05);
account.deposit(500);
account.withdraw(200);
account.calculateInterest();
console.log(account.getBalance());
```