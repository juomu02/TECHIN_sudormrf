# TECHIN_sudormrf
Baigiamasis projektas


## Projekto paleidimas

### 1. Docker konteinerio sukūrimo komanda
```
docker run --name MySavings -e MYSQL_ROOT_PASSWORD=root -d -p 3306:3306 mysql:lts
```

### 3. React projekto paleidimas
\*leidžiama iš ./MySavings.React/ direktorijos
```
npm run dev
```
