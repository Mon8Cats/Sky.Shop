namespace Discount.Grpc.Settings
{
    public class NpgsqlSettings
    {
        //"ConnectionString": "Server=localhost;Port=5432;Database=DiscountDb;User Id=admin;Password=admin1234;"
        public string Host { get; init; }
        public int Port { get; init; }
        public string User { get; init; }
        public string Password { get; init; }

        public string Database { get; init; }
        //public string ConnectionString { get; set; }

        public string ConnectionString => $"Server={Host};Port={Port};Database={Database};User Id={User};Password={Password};";
    }
}