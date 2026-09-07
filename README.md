# 3ITA-VA-2026-27

Materiály k výuce programování v jazyce C# — školní rok 2026/27.

Najdete tu zápisky a ukázkové projekty z hodin, seřazené podle témat v pořadí,
v jakém na sebe navazují. Každá kapitola má vlastní `README.md` s vysvětlením
a složku `ukazky/`, kde je funkční kód ke stažení a spuštění.

## Obsah

| Kapitola | Téma |
| --- | --- |
| [01-zaklady](01-zaklady) | Proměnné, datové typy, vstup a výstup, podmínky, cykly |
| [02-oop](02-oop) | Třídy, objekty, zapouzdření, dědičnost |
| [03-winforms](03-winforms) | Desktopové aplikace s WinForms |
| [04-wpf](04-wpf) | Desktopové aplikace s WPF |
| [ulohy-z-hodiny](ulohy-z-hodiny) | Zadání a řešení jednotlivých hodin podle skupin a data |

## Co budete potřebovat

- **Visual Studio 2022** (Community edice stačí) s workloadem *.NET desktop
  development* — bez něj nejdou WinForms ani WPF projekty otevřít.
- Alternativně **VS Code** + **.NET SDK** — pro kapitolu 01 a 02 to bohatě
  stačí, WinForms a WPF ale potřebují Windows (na macOS/Linuxu se nedají
  spustit).

## Jak se dostat ke kódu

Buď si repozitář naklonujte:

```bash
git clone https://github.com/dominiknemecek/3ITA-VA-2026-27.git
```

nebo si stáhněte aktuální stav jako ZIP tlačítkem **Code → Download ZIP**
nahoře na této stránce — na to není potřeba žádný GitHub účet ani Git.

Konkrétní projekt v `ukazky/` pak otevřete přes jeho `.csproj` (nebo přes
`.sln`, pokud tam je) ve Visual Studiu, případně ho spustíte příkazem
`dotnet run` ve složce s daným projektem.

## Průběžná aktualizace

Repozitář se bude v průběhu roku doplňovat o nové kapitoly a zápisky
z aktuálních hodin — pro nejnovější verzi si ho čas od času stáhněte znovu
(`git pull`, nebo nový ZIP).

## Licence

Materiály jsou k dispozici pod licencí [MIT](LICENSE).
