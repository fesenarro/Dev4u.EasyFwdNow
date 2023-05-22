import { mapEnumToOptions } from '@abp/ng.core';

export enum TipoVisibilidad {
  Todos = 0,
  Interno = 1,
  Externo = 2,
}

export const tipoVisibilidadOptions = mapEnumToOptions(TipoVisibilidad);
