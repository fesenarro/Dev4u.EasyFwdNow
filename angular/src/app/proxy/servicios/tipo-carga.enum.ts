import { mapEnumToOptions } from '@abp/ng.core';

export enum TipoCarga {
  Contenedor = 0,
  CargaSuelta = 1,
}

export const tipoCargaOptions = mapEnumToOptions(TipoCarga);
