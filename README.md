# 🔐 C# Const vs Readonly Example

This program demonstrates the difference between `const` and `readonly` in C#, and how both can be used in calculations.

---

## 📘 What You Learn

- `const`: Compile-time constant, value must be assigned immediately.
- `readonly`: Run-time constant, can be assigned inside a constructor.
- Area calculation using both types of constants.

---

## 💡 Code Overview

```csharp
const float pi = 3.1459f;
readonly float pie;

Program() {
    pie = 3.1459f;
}

res = pi * rad * rad;   // Using const
res = p.pie * rad * rad; // Using readonly

 
