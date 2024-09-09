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
}