# Discount Rules Engine

## 1. Problem Statement 

The objective of this project is to build a Discount Rules Engine using SOLID - Open/Clsoed principle .
Apply discounts while allowing new discount rules to be added without modifying the checkout calculator.

The discount rules implemented in this project are:

- **Premium Discount Rule**: Applies a 15% discount when the subtotal is ₹2000 or more.
- **Bulk Discount Rule**: Applies a ₹200 discount when the subtotal is ₹1500 or more.
- **Festival Discount Rule**: Applies a 10% discount when the subtotal is ₹500 or more.
-The additional **StudentDiscountRule** :  provides a 10% discount on the subtotal. It is primarily used to test the extensibility of the discount engine and verify that a newly added rule is automatically considered by the DiscountCalculator without requiring any changes to the calculator itself.

## 2. Design Overview 

The project uses an interface-based design.

`IDiscountRule` defines a common `Apply()` method that every discount rule must implement.

The `DiscountCalculator` receives a collection of `IDiscountRule` objects. It calculates the final amount by applying the rules to the subtotal.

This design follows the **Open/Closed Principle (OCP)** because new discount rules can be added by creating a new class implementing `IDiscountRule`, without modifying the existing discount rule classes.


## 3. Build Command 

- dotnet build 

## 4. Test Command 

- dotnet test

## 5.Test Summary 

The project contains 7 unit tests covering the implemented discount rules and the extensibility of the discount engine.

- **PremiumDiscountRule:** 2 tests
  - Verifies that a 15% discount is applied when the subtotal is ₹2000 or more.
  - Verifies that no discount is applied when the subtotal is below ₹2000.

- **BulkDiscountRule:** 2 tests
  - Verifies that ₹200 is subtracted when the subtotal is ₹1500 or more.
  - Verifies that no discount is applied when the subtotal is below ₹1500.

- **FestivalDiscountRule:** 2 tests
  - Verifies that a 10% discount is applied when the subtotal is ₹500 or more.
  - Verifies that no discount is applied when the subtotal is below ₹500.

- **Adding a New Rule:** 1 test
  - Verifies that a new `StudentDiscountRule` can be added through the `IDiscountRule` extension point and is correctly processed by `DiscountCalculator` without modifying the calculator.

## 6.Limitations

- The discount rules are applied **sequentially**, so the order in which rules are supplied to `DiscountCalculator` can affect the final result.

- There is currently no **rule-priority or ordering mechanism**, so the system relies on the order in which the rules are provided.