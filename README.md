# Dokumentacja projetu: 

## Opis projektu:

Museum Ticket App to desktopowa aplikacja Windows Forms służąca do zakupu biletów na wystawy muzealne. Umożliwia użytkownikowi wybór wystawy, rodzaju biletu i ilości wejściówek, generując podsumowanie zamówienia. Dodatkowo aplikacja oferuje panel administracyjny, pozwalający na edycję danych w bazie.

Projekt został stworzony w języku C# z użyciem Entity Framework oraz relacyjnej bazy danych PostgreSQL.

## Zakres projektu opis funkcjonalności:

1. Zakup biletów
- Wybór wystawy z listy aktualnie dostępnych.
- Wybór rodzaju biletu (np. normalny, ulgowy).
- Wskazanie liczby biletów (od 1 do 10).
- Automatyczne obliczanie łącznej ceny.

2. Podsumowanie zamówienia
- Wyświetlenie szczegółów zamówienia: wystawa, rodzaje i liczby biletów, suma do zapłaty.
- Potwierdzenie zamówienia i zapis do bazy danych.

3. Potwierdzenie sukcesu
- Komunikat o prawidłowym zakończeniu transakcji.

4. Panel administratora
- Możliwość podglądu i edycji danych w tabelach: wystawy, typy biletów, zamówienia i ich składniki.
- Zmiany zapisywane w bazie danych po zatwierdzeniu.

## Struktura aplikacji

### Formularze:

1. MainForm – formularz główny z możliwością wyboru wystawy.

2. TicketSelectionForm – formularz wyboru rodzaju i ilości biletów.

3. SummaryForm – formularz podsumowujący zamówienie

4. SuccessForm – komunikat po udanym zamówieniu. 

5. AdminPanelForm – narzędzie administracyjne do zarządzania danymi.

## Baza danych

Baza danych zawiera cztery tabele:

[Exhibition]
  - Id (PK)
  - Title
  - Description
  - StartDate
  - EndDate

[TicketType]
  - Id (PK)
  - Name
  - Price

[TicketOrder]
  - Id (PK)
  - PurchaseDate

[TicketItem]
  - Id (PK)
  - TicketOrderId (FK → TicketOrder.Id)
  - TicketTypeId (FK → TicketType.Id)
  - ExhibitionId (FK → Exhibition.Id)
  - Quantity

Relacje:

Exhibition <-> TicketItem: 1:N – jedna wystawa może występować w wielu pozycjach zamówień.

TicketType <-> TicketItem: 1:N – jeden typ biletu może wystąpić w wielu pozycjach.

TicketOrder <-> TicketItem: 1:N – jedno zamówienie może zawierać wiele pozycji.

TicketItem pełni rolę encji łączącej: zamówienie, rodzaj biletu i wystawę.

## Wykorzystane biblioteki:
- C# 
- Windows Forms
- Entity Framework
- PostgreSQL
- Visual Studio

## Instrukcja uruchomienia aplikacji
1. **Sklonuj repozytorium:**
   - Pobierz ZIP z GitHuba lub użyj Git GUI, np. GitHub Desktop.

2. **Utwórz bazę danych:**
   - Uruchom pgAdmin lub inny interfejs PostgreSQL.
   - Stwórz nową bazę danych o nazwie `museum`.

3. **Skonfiguruj połączenie z bazą w `App.config`:**
   - Wartość `twojehaslo` podmień na swoje hasło do pgAdmin.

4. **Uruchom aplikację:**
   - Otwórz projekt w Visual Studio i naciśnij F5