﻿namespace AutoGestion.Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPrincipal = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            aBMUsToolStripMenuItem = new ToolStripMenuItem();
            gestionVentasToolStripMenuItem = new ToolStripMenuItem();
            mnuSolicitarModelo = new ToolStripMenuItem();
            mnuRegistrarCliente = new ToolStripMenuItem();
            mnuRealizarPago = new ToolStripMenuItem();
            mnuAutorizarVenta = new ToolStripMenuItem();
            mnuEmitirFactura = new ToolStripMenuItem();
            mnuRealizarEntrega = new ToolStripMenuItem();
            gestiónComprasToolStripMenuItem = new ToolStripMenuItem();
            mnuRegistrarOferta = new ToolStripMenuItem();
            mnuEvaluarVehiculo = new ToolStripMenuItem();
            mnuTasarVehiculo = new ToolStripMenuItem();
            mnuRegistrarCompra = new ToolStripMenuItem();
            gestionComisionesToolStripMenuItem = new ToolStripMenuItem();
            mnuRegistrarComision = new ToolStripMenuItem();
            mnuConsultarComisiones = new ToolStripMenuItem();
            gestiónTurnosToolStripMenuItem = new ToolStripMenuItem();
            mnuRegistrarTurno = new ToolStripMenuItem();
            mnuRegistrarAsistencia = new ToolStripMenuItem();
            seguridadToolStripMenuItem = new ToolStripMenuItem();
            mnuAsignarRoles = new ToolStripMenuItem();
            mnuCerrarSesion = new ToolStripMenuItem();
            panelContenido = new Panel();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, gestionVentasToolStripMenuItem, gestiónComprasToolStripMenuItem, gestionComisionesToolStripMenuItem, gestiónTurnosToolStripMenuItem, seguridadToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(800, 24);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aBMUsToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // aBMUsToolStripMenuItem
            // 
            aBMUsToolStripMenuItem.Name = "aBMUsToolStripMenuItem";
            aBMUsToolStripMenuItem.Size = new Size(148, 22);
            aBMUsToolStripMenuItem.Text = "ABM Usuarios";
            aBMUsToolStripMenuItem.Click += aBMUsToolStripMenuItem_Click;
            // 
            // gestionVentasToolStripMenuItem
            // 
            gestionVentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuSolicitarModelo, mnuRegistrarCliente, mnuRealizarPago, mnuAutorizarVenta, mnuEmitirFactura, mnuRealizarEntrega });
            gestionVentasToolStripMenuItem.Name = "gestionVentasToolStripMenuItem";
            gestionVentasToolStripMenuItem.Size = new Size(96, 20);
            gestionVentasToolStripMenuItem.Text = "Gestión Ventas";
            // 
            // mnuSolicitarModelo
            // 
            mnuSolicitarModelo.Name = "mnuSolicitarModelo";
            mnuSolicitarModelo.Size = new Size(160, 22);
            mnuSolicitarModelo.Text = "Solicitar Modelo";
            mnuSolicitarModelo.Click += mnuSolicitarModelo_Click;
            // 
            // mnuRegistrarCliente
            // 
            mnuRegistrarCliente.Name = "mnuRegistrarCliente";
            mnuRegistrarCliente.Size = new Size(160, 22);
            mnuRegistrarCliente.Text = "Registrar Cliente";
            mnuRegistrarCliente.Click += mnuRegistrarCliente_Click;
            // 
            // mnuRealizarPago
            // 
            mnuRealizarPago.Name = "mnuRealizarPago";
            mnuRealizarPago.Size = new Size(160, 22);
            mnuRealizarPago.Text = "Realizar Pago";
            mnuRealizarPago.Click += mnuRealizarPago_Click;
            // 
            // mnuAutorizarVenta
            // 
            mnuAutorizarVenta.Name = "mnuAutorizarVenta";
            mnuAutorizarVenta.Size = new Size(160, 22);
            mnuAutorizarVenta.Text = "Autorizar Venta";
            mnuAutorizarVenta.Click += mnuAutorizarVenta_Click;
            // 
            // mnuEmitirFactura
            // 
            mnuEmitirFactura.Name = "mnuEmitirFactura";
            mnuEmitirFactura.Size = new Size(160, 22);
            mnuEmitirFactura.Text = "Emitir Factura";
            mnuEmitirFactura.Click += mnuEmitirFactura_Click;
            // 
            // mnuRealizarEntrega
            // 
            mnuRealizarEntrega.Name = "mnuRealizarEntrega";
            mnuRealizarEntrega.Size = new Size(160, 22);
            mnuRealizarEntrega.Text = "Realizar Entrega";
            mnuRealizarEntrega.Click += mnuRealizarEntrega_Click;
            // 
            // gestiónComprasToolStripMenuItem
            // 
            gestiónComprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuRegistrarOferta, mnuEvaluarVehiculo, mnuTasarVehiculo, mnuRegistrarCompra });
            gestiónComprasToolStripMenuItem.Name = "gestiónComprasToolStripMenuItem";
            gestiónComprasToolStripMenuItem.Size = new Size(110, 20);
            gestiónComprasToolStripMenuItem.Text = "Gestión Compras";
            // 
            // mnuRegistrarOferta
            // 
            mnuRegistrarOferta.Name = "mnuRegistrarOferta";
            mnuRegistrarOferta.Size = new Size(166, 22);
            mnuRegistrarOferta.Text = "Registrar Oferta";
            mnuRegistrarOferta.Click += mnuRegistrarOferta_Click;
            // 
            // mnuEvaluarVehiculo
            // 
            mnuEvaluarVehiculo.Name = "mnuEvaluarVehiculo";
            mnuEvaluarVehiculo.Size = new Size(166, 22);
            mnuEvaluarVehiculo.Text = "Evaluar Vehículo";
            mnuEvaluarVehiculo.Click += mnuEvaluarVehiculo_Click;
            // 
            // mnuTasarVehiculo
            // 
            mnuTasarVehiculo.Name = "mnuTasarVehiculo";
            mnuTasarVehiculo.Size = new Size(166, 22);
            mnuTasarVehiculo.Text = "Tasar Vehículo";
            mnuTasarVehiculo.Click += mnuTasarVehiculo_Click;
            // 
            // mnuRegistrarCompra
            // 
            mnuRegistrarCompra.Name = "mnuRegistrarCompra";
            mnuRegistrarCompra.Size = new Size(166, 22);
            mnuRegistrarCompra.Text = "Registrar Compra";
            mnuRegistrarCompra.Click += mnuRegistrarCompra_Click;
            // 
            // gestionComisionesToolStripMenuItem
            // 
            gestionComisionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuRegistrarComision, mnuConsultarComisiones });
            gestionComisionesToolStripMenuItem.Name = "gestionComisionesToolStripMenuItem";
            gestionComisionesToolStripMenuItem.Size = new Size(124, 20);
            gestionComisionesToolStripMenuItem.Text = "Gestión Comisiones";
            // 
            // mnuRegistrarComision
            // 
            mnuRegistrarComision.Name = "mnuRegistrarComision";
            mnuRegistrarComision.Size = new Size(190, 22);
            mnuRegistrarComision.Text = "Registrar Comisión";
            mnuRegistrarComision.Click += mnuRegistrarComision_Click;
            // 
            // mnuConsultarComisiones
            // 
            mnuConsultarComisiones.Name = "mnuConsultarComisiones";
            mnuConsultarComisiones.Size = new Size(190, 22);
            mnuConsultarComisiones.Text = "Consultar Comisiones";
            mnuConsultarComisiones.Click += mnuConsultarComisiones_Click;
            // 
            // gestiónTurnosToolStripMenuItem
            // 
            gestiónTurnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuRegistrarTurno, mnuRegistrarAsistencia });
            gestiónTurnosToolStripMenuItem.Name = "gestiónTurnosToolStripMenuItem";
            gestiónTurnosToolStripMenuItem.Size = new Size(99, 20);
            gestiónTurnosToolStripMenuItem.Text = "Gestión Turnos";
            // 
            // mnuRegistrarTurno
            // 
            mnuRegistrarTurno.Name = "mnuRegistrarTurno";
            mnuRegistrarTurno.Size = new Size(176, 22);
            mnuRegistrarTurno.Text = "Registrar Turno";
            mnuRegistrarTurno.Click += mnuRegistrarTurno_Click;
            // 
            // mnuRegistrarAsistencia
            // 
            mnuRegistrarAsistencia.Name = "mnuRegistrarAsistencia";
            mnuRegistrarAsistencia.Size = new Size(176, 22);
            mnuRegistrarAsistencia.Text = "Registrar Asistencia";
            mnuRegistrarAsistencia.Click += mnuRegistrarAsistencia_Click;
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAsignarRoles, mnuCerrarSesion });
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(72, 20);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // mnuAsignarRoles
            // 
            mnuAsignarRoles.Name = "mnuAsignarRoles";
            mnuAsignarRoles.Size = new Size(180, 22);
            mnuAsignarRoles.Text = "Asignar Roles";
            mnuAsignarRoles.Click += asignarRolesToolStripMenuItem_Click;
            // 
            // mnuCerrarSesion
            // 
            mnuCerrarSesion.Name = "mnuCerrarSesion";
            mnuCerrarSesion.Size = new Size(180, 22);
            mnuCerrarSesion.Text = "Cerrar Sesión";
            mnuCerrarSesion.Click += mnuCerrarSesion_Click;
            // 
            // panelContenido
            // 
            panelContenido.BorderStyle = BorderStyle.FixedSingle;
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 24);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(800, 426);
            panelContenido.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenido);
            Controls.Add(menuPrincipal);
            MainMenuStrip = menuPrincipal;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem gestionVentasToolStripMenuItem;
        private ToolStripMenuItem mnuSolicitarModelo;
        private ToolStripMenuItem mnuRegistrarCliente;
        private ToolStripMenuItem mnuRealizarPago;
        private ToolStripMenuItem mnuAutorizarVenta;
        private ToolStripMenuItem mnuEmitirFactura;
        private ToolStripMenuItem mnuRealizarEntrega;
        private ToolStripMenuItem gestiónComprasToolStripMenuItem;
        private ToolStripMenuItem mnuRegistrarOferta;
        private ToolStripMenuItem mnuEvaluarVehiculo;
        private ToolStripMenuItem mnuTasarVehiculo;
        private ToolStripMenuItem mnuRegistrarCompra;
        private ToolStripMenuItem gestionComisionesToolStripMenuItem;
        private ToolStripMenuItem mnuRegistrarComision;
        private ToolStripMenuItem mnuConsultarComisiones;
        private ToolStripMenuItem gestiónTurnosToolStripMenuItem;
        private ToolStripMenuItem mnuRegistrarTurno;
        private ToolStripMenuItem mnuRegistrarAsistencia;
        private Panel panelContenido;
        private ToolStripMenuItem seguridadToolStripMenuItem;
        private ToolStripMenuItem mnuAsignarRoles;
        private ToolStripMenuItem mnuCerrarSesion;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem aBMUsToolStripMenuItem;
    }
}
