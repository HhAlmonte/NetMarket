﻿using Core.Entities.OrdenCompra;

namespace WebApi.DTOs
{
    public class OrdenCompraReponseDto
    {
        public int Id { get; set; }
        public string CompradorEmail { get; set; }
        public DateTimeOffset OrdenCompraFecha { get; set; }
        public Direccion DireccionEnvio { get; set; }
        public string TipoEnvio { get; set; }
        public decimal TipoEnvioPrecio { get; set; }
        public IReadOnlyList<OrdenItemResponseDto> OrderItems { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
    }
}
