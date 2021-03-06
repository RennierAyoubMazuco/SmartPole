﻿using Android.Telephony;
using Android.Webkit;
using Java.Net;
using Newtonsoft.Json;
using SmartPole.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPole.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private const string URL_BASE = "http://143.107.145.32";
        private const string GET_ENTITIES = ":1026/v2/entities/";
        public UsuarioModel Usuario { get; set; }
        public string Login
        {
            get
            {
                return Usuario.Login;
            }
            set
            {
                Usuario.Login = value;
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
            CmdLogin = new Command(async () =>
            {
                if (await ValidaUsuario())
                    MessagingCenter.Send<UsuarioModel>(Usuario, "SucessoLogin");               
            }, () =>
             {
                 return !string.IsNullOrEmpty(Login)
                 && !string.IsNullOrEmpty(Senha);
             });
            CmdSobre = new Command(() =>
            {
                MessagingCenter.Send<String>(String.Empty, "Sobre");
            });
        }
        public ICommand CmdLogin { get; set; }
        public ICommand CmdSobre { get; set; }

        public async Task<bool> ValidaUsuario()
        {
            using (HttpClient cliente = new HttpClient())
            {
                //cliente.BaseAddress = new Uri();

                cliente.DefaultRequestHeaders.Add("Accept", "application/json");
                cliente.DefaultRequestHeaders.Add("fiware-service", "helixiot");
                cliente.DefaultRequestHeaders.Add("fiware-servicepath", "/");

                try
                {
                    HttpResponseMessage resposta = await cliente.GetAsync(URL_BASE + GET_ENTITIES + Usuario.Login);
                    if (resposta.IsSuccessStatusCode)
                    {
                        string conteudo = await resposta.Content.ReadAsStringAsync();
                        UsuarioJson usuariojson = JsonConvert.DeserializeObject<UsuarioJson>(conteudo);

                        return usuariojson.senha.value == Senha;
                    }
                    else
                    {
                        MessagingCenter.Send<String>("Usuario/Senha incorretos.", "FalhaLogin");
                    }

                }
                catch (HttpRequestException)
                {
                    MessagingCenter.Send<String>("Não foi possivel efetuar o login, verifique a sua conexão e tente novamente.", "FalhaLogin");
                }
                return false;
            }            
        }
    }
}
