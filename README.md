# TECHIN_sudormrf
Baigiamasis projektas


## Projekto paleidimas

### 1. Docker konteinerio sukūrimo komanda
```
docker run --name MySavings -e MYSQL_ROOT_PASSWORD=root -d -p 3306:3306 mysql:lts
```
### 2. API rojekto paleidimas
\*leidžiama iš ./MySavings.API/ direktorijos
```
dotnet run
```

### 3. React projekto paleidimas
\*leidžiama iš ./MySavings.React/ direktorijos
```
npm run dev
```

## DB migracijos komandos
### Migracijų atnaujinimas rankiniu būdu
```
dotnet ef database update
```
### Migracijos pridėjimas
\*Čia pavyzdys. Kuriant naują migraciją reikia pakeisti pavadinimą
```
dotnet ef migrations add AddTestMigration 
```