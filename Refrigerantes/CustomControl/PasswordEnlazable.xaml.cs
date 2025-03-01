﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Refrigerantes.CustomControl
{
    /// <summary>
    /// Lógica de interacción para PasswordEnlazable.xaml
    /// </summary>
    public partial class PasswordEnlazable : UserControl
    {
        public static readonly DependencyProperty passwordProperty =
            DependencyProperty.Register("Password", typeof(Byte[]), typeof(PasswordEnlazable));
        public Byte[] Password
        {
            get { return (Byte[])GetValue(passwordProperty); }
            set { SetValue(passwordProperty, value); }
        }

        //Se genera cada vez que el control cambia.
        public PasswordEnlazable()
        {
            InitializeComponent();
            pwBoxCustom.PasswordChanged += OnPasswordChanged;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = Encriptar(pwBoxCustom.Password);
        }

        /// <summary>
        /// Encripta en SHA256 el string pasado por parametro
        /// </summary>
        /// <returns>String en codificacion SHA256</returns>
        private byte[] Encriptar(string texto)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] hashValue;
                byte[] message = Encoding.UTF8.GetBytes(texto);

                hashValue = mySHA256.ComputeHash(message);

                return hashValue;
            }
        }
    }
}
