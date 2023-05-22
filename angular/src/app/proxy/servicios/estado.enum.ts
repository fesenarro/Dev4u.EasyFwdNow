import { mapEnumToOptions } from '@abp/ng.core';

export enum Estado {
  Activo = 0,
  Inactivo = 1,
}

export const estadoOptions = mapEnumToOptions(Estado);
