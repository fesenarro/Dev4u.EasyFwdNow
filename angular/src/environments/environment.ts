import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'EasyFwdNow',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44334/',
    redirectUri: baseUrl,
    clientId: 'EasyFwdNow_App',
    responseType: 'code',
    scope: 'offline_access EasyFwdNow',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44354',
      rootNamespace: 'Dev4u.EasyFwdNow',
    },
  },
} as Environment;
