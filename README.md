# SimpleUserAPI

**Descrizione:**
SimpleUserAPI è un progetto ASP.NET Core che implementa una semplice CRUD per gestire utenti tramite REST API, utilizzando un database fittizio in memoria. È pensato come progetto di apprendimento per sperimentare le operazioni base di Create, Read, Update e Delete.

---

## Caratteristiche principali

- **GET** `/api/user?idUser={id}` → Recupera un utente specifico tramite ID  
- **GET** `/api/user/all` → Recupera tutti gli utenti  
- **POST** `/api/user` → Aggiunge un nuovo utente  
- **PUT** `/api/user` → Aggiorna un utente esistente  
- **DELETE** `/api/user?idUser={id}` → Elimina un utente  

**Struttura del progetto:**

```
/Model
    /Request
        AddUserRequest.cs
        UpdateUserRequest.cs
/Controllers
    UserController.cs
/Database
    FakeDatabase.cs
Program.cs
```

---

## Tecnologie

- ASP.NET Core  
- C#  
- REST API  

---

## Come eseguire il progetto

1. Clona la repository:  
```bash
git clone https://github.com/OvrTnkDev/aspnet-fakeuser-crud-api.git
```

2. Apri il progetto con Visual Studio o VS Code.

3. Esegui il progetto (`F5` o `dotnet run`) e utilizza Postman o un browser per testare le API.

---

## Contribuire

Il progetto è open-source e pensato per sperimentazioni didattiche. Per contribuire:

1. Fork del repository  
2. Crea un branch per la tua feature (`git checkout -b feature/NomeFeature`)  
3. Effettua i tuoi cambiamenti  
4. Apri una Pull Request  

---

## Licenza

MIT License - libero da usare e modificare.

