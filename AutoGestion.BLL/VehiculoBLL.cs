﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoGestion.BE;
using AutoGestion.DAO;
using AutoGestion.Servicios;


namespace AutoGestion.BLL
{
    public class VehiculoBLL
    {
        private readonly XmlRepository<Vehiculo> _repo = new("vehiculos.xml");

        public List<Vehiculo> BuscarVehiculosPorModelo(string modelo)
        {
            return _repo.ObtenerTodos()
                        .Where(v => v.Modelo.ToLower() == modelo.ToLower() && v.Estado == "Disponible")
                        .ToList();
        }

        public List<Vehiculo> BuscarVehiculosSimilares(string modelo)
        {
            var lista = _repo.ObtenerTodos();

            return lista.Where(v =>
                v.Modelo.Contains(modelo, StringComparison.OrdinalIgnoreCase) ||
                v.Marca.Contains(modelo, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        public void ActualizarEstadoStock(Vehiculo vehiculo, string estado)
        {
            var lista = _repo.ObtenerTodos();
            var v = lista.FirstOrDefault(x => x.Dominio == vehiculo.Dominio);
            if (v != null)
            {
                v.Estado = estado;
                _repo.GuardarLista(lista);
            }
        }

        public void ActualizarDatosVehiculo(Vehiculo vehiculo, string datosTecnicos)
        {
            var lista = _repo.ObtenerTodos();
            var v = lista.FirstOrDefault(x => x.Dominio == vehiculo.Dominio);
            if (v != null)
            {
                v.Estado = datosTecnicos;
                _repo.GuardarLista(lista);
            }
        }

        public Vehiculo BuscarVehiculoPorDominio(string dominio)
        {
            return _repo.ObtenerTodos()
                        .FirstOrDefault(v => v.Dominio.Equals(dominio, StringComparison.OrdinalIgnoreCase));
        }

        public List<Vehiculo> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }

        public List<Vehiculo> ObtenerDisponibles()
        {
            return _repo.ObtenerTodos().Where(v => v.Estado == "Disponible").ToList();
        }

        public void ActualizarEstadoVehiculo(Vehiculo vehiculo, string nuevoEstado)
        {
            var lista = _repo.ObtenerTodos();
            var existente = lista.FirstOrDefault(v => v.ID == vehiculo.ID);

            if (existente != null)
            {
                existente.Estado = nuevoEstado;
                _repo.GuardarLista(lista);
            }
        }

        public void ActualizarVehiculo(Vehiculo vehiculo)
        {
            var lista = _repo.ObtenerTodos();
            var existente = lista.FirstOrDefault(v => v.ID == vehiculo.ID);

            if (existente != null)
            {
                // Copia los datos del objeto recibido al que está en la lista
                existente.Marca = vehiculo.Marca;
                existente.Modelo = vehiculo.Modelo;
                existente.Año = vehiculo.Año;
                existente.Color = vehiculo.Color;
                existente.Km = vehiculo.Km;
                existente.Dominio = vehiculo.Dominio;
                existente.Estado = vehiculo.Estado;

                _repo.GuardarLista(lista);
            }
        }

        public void AgregarVehiculoAlStock(Vehiculo vehiculo)
        {
            var lista = _repo.ObtenerTodos();
            vehiculo.ID = GeneradorID.ObtenerID<Vehiculo>();
            vehiculo.Estado = "Disponible"; // lo dejamos listo para la venta
            lista.Add(vehiculo);
            _repo.GuardarLista(lista);
        }










    }
}
