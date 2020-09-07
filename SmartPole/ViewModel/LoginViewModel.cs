using SmartPole.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartPole.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public UsuarioModel Usuario { get; set; }
        public string Email
        {
            get
            {
                return Usuario.Email;
            }
            set
            {
                Usuario.Email = value;
                OnPropertyChanged();
                ((Command)CmdLogin).ChangeCanExecute();
            }
        }
        public string Senha
        {
            get
            {
                return Usuario.Senha;
            }
            set
            {
                Usuario.Senha = value;
                OnPropertyChanged();
                ((Command)CmdLogin).ChangeCanExecute();
            }
        }

        public LoginViewModel()
        {
            Usuario = new UsuarioModel();
            CmdLogin = new Command(()=>
            {
                MessagingCenter.Send<UsuarioModel>(Usuario, "SucessoLogin");
            },()=>
            {
                return !string.IsNullOrEmpty(Email)
                && !string.IsNullOrEmpty(Senha);
            });
        }
        public ICommand CmdLogin { get; set; }

    }
}
