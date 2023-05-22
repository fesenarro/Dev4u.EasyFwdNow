import type { TipoCategoria } from './tipo-categoria.enum';
import type { TipoVisibilidad } from './tipo-visibilidad.enum';
import type { TipoCarga } from './tipo-carga.enum';
import type { Estado } from './estado.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateServicioDto {
  codigo: string;
  nombre: string;
  descripcion: string;
  tipo: TipoCategoria;
  visibilidad: TipoVisibilidad;
  carga: TipoCarga;
  estado: Estado;
  requiereCantidad: number;
  requiereMonto: number;
  requiereHoras: number;
}

export interface ServicioDto extends AuditedEntityDto<string> {
  codigo?: string;
  nombre?: string;
  descripcion?: string;
  tipo: TipoCategoria;
  visibilidad: TipoVisibilidad;
  carga: TipoCarga;
  estado: Estado;
  requiereCantidad: number;
  requiereMonto: number;
  requiereHoras: number;
}
