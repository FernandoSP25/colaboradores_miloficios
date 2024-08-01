namespace colaboradores_miloficios
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Colaboradores", typeof(Login1Page));
            Routing.RegisterRoute("Invitados", typeof(Login2Page));
        }
    }
}
