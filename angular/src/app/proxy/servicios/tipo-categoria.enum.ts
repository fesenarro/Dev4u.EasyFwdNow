import { mapEnumToOptions } from '@abp/ng.core';

export enum TipoCategoria {
  ImpoExpo = 0,
  Importacion = 1,
  Exportacion = 2,
}

export const tipoCategoriaOptions = mapEnumToOptions(TipoCategoria);
