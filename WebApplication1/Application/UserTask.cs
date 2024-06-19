namespace WebApplication1.Application
{
    public class UserTask:IUserTask
    {
        private readonly DataContext _context;
        public UserTask(DataContext context)
        {
            _context = context;                
        }
        public User AddUser(User us) {

            var exist = _context.Users.FirstOrDefault(x => x.Correo == us.Correo);
            if (exist == null) {
                _context.Users.Add(us);
                _context.SaveChanges();
                return us;
            }
            throw new Exception("Usuario Ya xiste");
          
        }
        public void EditUser(User us)
        {
            var edit = _context.Users.FirstOrDefault(x => x.Id == us.Id);
            if (edit != null)
            {
                edit.Nombre= us.Nombre;
                
                _context.Users.Update(edit);
                _context.SaveChanges();
                return;
            }
            throw new Exception("Usuario No xiste");
        }
        public List<User> Get()
        {
            return _context.Users.ToList();  
        }
        public User Get(Guid idUs)
        {
            var result =  _context.Users.FirstOrDefault(x => x.Id == idUs);
            if (result != null) { 
                return result;
            }
            throw new Exception("Usuario No xiste");
        }
        public void Delete(Guid idUs)
        {
            var delete = _context.Users.FirstOrDefault(x => x.Id == idUs);
            if (delete != null)
            {              
                _context.Users.Remove(delete);
                _context.SaveChanges();
                return;
            }
            throw new Exception("Usuario No xiste");
        }

    }
}
