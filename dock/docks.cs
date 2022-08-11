

namespace airforce {
    internal class Docks {

        private string _user;
        private int _password;
        public string HostUser {
            get { return HostUser; }
            set {
                Console.WriteLine("..."); 
            }
        }
        public int Ip {
            get { return Ip; }
            set {
                Console.WriteLine("...");
            } 
        }


        public Docks() { }

        public Docks(string user) {
            _user = user;
        }

        public Docks(string user, int password) : this(user) {
            _password = password;
        }

        public Docks(string user, int password, int ip) : this(user, password) {
            Ip = ip;
            
        }

        public string User {

            get { return _user; }
            set {
                if(value != null && value.Length > 6) {
                    Console.WriteLine("...");
                    
                }
                else {
                    Console.WriteLine("...");
                    Console.WriteLine($"Usuário não aceito");
                }
            }

        }

        public int Password {

            get { return _password; }

            set {
                if(value != null && value > 3) {
                    Console.WriteLine("...");
                   
                }
                else {
                    Console.WriteLine("...");
                    Console.WriteLine("Senha negada");
                }
            }

        }

    }
}
