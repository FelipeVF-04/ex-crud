namespace ex_crud.Models //model representa uma tabela do banco de dados. Propriedade = coluna no banco de dados
{

    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public static class UserStore // classes estaticas não podem ser instanciadas
    {
        public static Dictionary<Guid, User> Users = new Dictionary<Guid, User>();
    }

}