using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model.Request;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")] // api/user -> analizza in name del controller e inserisce tutto ciò che c'è prima di "Controller"
    [ApiController]
    public class UserController : ControllerBase
    {
        // creo l'istanza del database fittizio
        private static FakeDatabase _db = new FakeDatabase();

        [HttpGet]
        public IActionResult GetUserById(int idUser)
        {
            // tiro fuori l'utente che mi occorre tramite Id dal database
            var user = _db.Users.FirstOrDefault(u => u.IdUser == idUser);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpGet("all")] //GET api/user/all -> in questo modo non c'è conflitto con il GetUserById
        public IActionResult AllUsers() 
        {
            // tiro fuori tutti gli utenti dal database
            return Ok(_db.Users);
        }

        [HttpDelete]
        public IActionResult DeleteUser(int idUser)
        {
            // cerco l'utente nel database
            var user = _db.Users.FirstOrDefault(u => u.IdUser == idUser);
            if (user == null)
                return NotFound();
            _db.Users.Remove(user);

            return Ok("User deleted");
        }

        [HttpPost]
        public IActionResult AddUser([FromBody]AddUserRequest user)
        {
            // vado ad inserire  l'utente nel database
            _db.AddUser(new User { IdUser = 0, Username = user.Username, Password = user.Password, Name = user.Name, Surname = user.Surname });
            
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] UpdateUserRequest user)
        {
            // cerco l'utente nel database
            var currentUser = _db.Users.FirstOrDefault(u => u.IdUser == user.IdUser);
            // controllo se l'utente esiste
            if (currentUser == null)
                return NotFound();

            // aggiorno solo i campi che non sono nulli nell'oggeto user altrimenti lascio i valori attuali
            currentUser.Username = user.Username ?? currentUser.Username;
            currentUser.Password = user.Password ?? currentUser.Password;
            currentUser.Name = user.Name ?? currentUser.Name;
            currentUser.Surname = user.Surname ?? currentUser.Surname;
            return Ok();
        }
    }
}
