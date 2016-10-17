﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace ServicoTeste
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void InstaladorServicoInspetor_AfterInstall(object sender, InstallEventArgs e)
        {                   
            ServiceController sc = new ServiceController(this.InstaladorServicoInspetor.ServiceName);
            sc.Start();
        }
    }
}
