```cpp
#include <iostream>
#include <string>
#include <map>

class Account {
public:
    Account(std::string id, double balance) : id(id), balance(balance), interestRate(0.01) {}

    void deposit(double amount) {
        balance += amount;
    }

    void withdraw(double amount) {
        if (balance >= amount) {
            balance -= amount;
        } else {
            std::cout << "Insufficient balance." << std::endl;
        }
    }

    void addInterest() {
        balance += balance * interestRate;
    }

    double getBalance() {
        return balance;
    }

private:
    std::string id;
    double balance;
    double interestRate;
};

class Bank {
public:
    void createAccount(std::string id, double initialDeposit) {
        if (accounts.find(id) == accounts.end()) {
            Account newAccount(id, initialDeposit);
            accounts[id] = newAccount;
        } else {
            std::cout << "Account already exists." << std::endl;
        }
    }

    void deposit(std::string id, double amount) {
        if (accounts.find(id) != accounts.end()) {
            accounts[id].deposit(amount);
        } else {
            std::cout << "Account does not exist." << std::endl;
        }
    }

    void withdraw(std::string id, double amount) {
        if (accounts.find(id) != accounts.end()) {
            accounts[id].withdraw(amount);
        } else {
            std::cout << "Account does not exist." << std::endl;
        }
    }

    void addInterest(std::string id) {
        if (accounts.find(id) != accounts.end()) {
            accounts[id].addInterest();
        } else {
            std::cout << "Account does not exist." << std::endl;
        }
    }

    double getBalance(std::string id) {
        if (accounts.find(id) != accounts.end()) {
            return accounts[id].getBalance();
        } else {
            std::cout << "Account does not exist." << std::endl;
            return -1;
        }
    }

private:
    std::map<std::string, Account> accounts;
};

int main() {
    Bank bank;
    bank.createAccount("123", 1000);
    bank.deposit("123", 500);
    bank.withdraw("123", 200);
    bank.addInterest("123");
    std::cout << "Balance: " << bank.getBalance("123") << std::endl;
    return 0;
}
```