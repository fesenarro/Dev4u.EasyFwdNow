import { NgModule } from '@angular/core';
// import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';

import { ServicioRoutingModule } from './servicio-routing.module';
import { ServicioComponent } from './servicio.component';


@NgModule({
  declarations: [
    ServicioComponent
  ],
  imports: [
    SharedModule,
    ServicioRoutingModule
  ]
})
export class ServicioModule { }
