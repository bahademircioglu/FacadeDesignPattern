# Facade Design Pattern Example: Loan Approval System

This project demonstrates the **Facade Design Pattern** by simulating a simplified loan approval process. The Facade pattern provides a unified interface to a complex subsystem, making it easier to use.

## Project Overview
The system checks if a customer is eligible for a loan by evaluating three criteria through a simplified interface (`Kredi` Facade):
1. **Account Balance Check** (`HesapBilgisi`)
2. **Credit Score Check** (`KrediSkoru`)
3. **Existing Loan Status Check** (`KredilerininDurumu`)

The `Kredi` Facade hides the complexity of these checks from the client code.

## Project Structure
| Class                   | Description                                                                 |
|-------------------------|-----------------------------------------------------------------------------|
| `Kredi` (Facade)        | Provides a simplified method `UygunMu()` to check loan eligibility.         |
| `HesapBilgisi`          | Checks if the customer has sufficient account balance.                      |
| `KrediSkoru`            | Validates the customer's credit score.                                      |
| `KredilerininDurumu`    | Verifies the status of the customer's existing loans.                       |
| `Musteri`               | Represents a customer with a name property.                                 |

## How It Works
1. The client creates a `Musteri` (Customer) and requests a loan amount.
2. The `Kredi` Facade coordinates three checks:
   - Account balance sufficiency
   - Credit score validity
   - Existing loan status
3. Loan approval is granted only if **all three checks pass**.

## Example Usage
```csharp
// Program.cs
Musteri musteri = new Musteri("Baha Demircioğlu");
Kredi kredi = new Kredi();
bool uygun = kredi.UygunMu(musteri, 125000);

Console.WriteLine($"\n{musteri.Name}'nun kredi isteği {(uygun ? "onaylandı!" : "reddedildi!")}");
```
### Output
```
Baha Demircioğlu, 125000e kadar kredi için başvuruda bulundu. Kontroller gerçekleştirilip, başvuru sonuçlandırılacak:

Baha Demircioğlu icin hesap kontrolu yapılıyor.
Baha Demircioğlu'nun mevcut kredileri kontrol ediliyor.
Baha Demircioğlu'nun kredi skoru kontrol ediliyor.

Baha Demircioğlu'nun kredi isteği onaylandı!
```
