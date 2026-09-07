# 04 — WPF

Modernější desktopový framework než WinForms. Rozložení okna se popisuje
deklarativně v XAML (podobné HTML), logika je v C# code-behind souboru
stejného jména.

> **Pouze Windows.** WPF aplikace se dají spustit jen ve Visual Studiu na
> Windows — na macOS ani Linuxu je spustit nejde.

## Co byste měli umět po této kapitole

- Číst a upravovat jednoduchý XAML — rozložení pomocí `Grid`/`StackPanel`
  a základní prvky (`Button`, `TextBox`, `TextBlock`).
- Napojit obsluhu události v XAML (`Click="..."`) na metodu v code-behind
  souboru.
- Chápat vztah `MainWindow.xaml` (jak okno vypadá) a `MainWindow.xaml.cs`
  (co dělá).

## Ukázky

| Projekt | Co ukazuje |
| --- | --- |
| [01-prvni-okno](ukazky/01-prvni-okno) | Tlačítko, textové pole — XAML rozložení + obsluha v code-behind |

## Zápisky z hodin

*(Sem budou postupně přibývat poznámky a zadání z jednotlivých hodin.)*
