import { Component,OnInit } from '@angular/core';
import { ListService,PagedResultDto } from "@abp/ng.core";
import { ServicioService,ServicioDto,tipoCargaOptions,tipoCategoriaOptions,tipoVisibilidadOptions, estadoOptions } from "@proxy/servicios";
import { FormGroup, FormBuilder, Validators } from '@angular/forms'; // add this
// add new imports
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-servicio',
  templateUrl: './servicio.component.html',
  styleUrls: ['./servicio.component.scss'],
  providers:[ListService],
})
export class ServicioComponent implements OnInit {
  servicio = { items:[],totalCount:0} as PagedResultDto<ServicioDto>;

  selectedServicio = {} as ServicioDto; // declare selectedBook

  form: FormGroup; // add this line

  // add bookTypes as a list of BookType enum members
  servicioCategorias = tipoCategoriaOptions;
  tipoVisibilidad = tipoVisibilidadOptions;
  tipoCarga = tipoCargaOptions;
  estados = estadoOptions;

  isModalOpen = false; // add this line
  
  constructor(public readonly list: ListService, private servicioService: ServicioService,private fb: FormBuilder, private confirmation: ConfirmationService) {}

  ngOnInit() {
    const servicioStreamCreator = (query) => this.servicioService.getList(query);

    this.list.hookToQuery(servicioStreamCreator).subscribe((response) => {
      this.servicio = response;
    });
  }

  // add new method
  createServicio() {
    this.selectedServicio = {} as ServicioDto;
    this.buildForm(); // add this line
    this.isModalOpen = true;
  }
// Add edit method
  editServicio(id: string){
    console.log(id);
    this.servicioService.get(id).subscribe((servicio)=>{
      console.log("objeto: " + servicio.codigo);
      this.selectedServicio = servicio;
      this.buildForm();
      this.isModalOpen=true;
    });
  }

  // Add a delete method
  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.servicioService.delete(id).subscribe(() => this.list.get());
      }
    });
  }

  // add buildForm method
  buildForm() {
    // this.form = this.fb.group({
    //   codigo: ['', Validators.required],
    //   nombre: [null, Validators.required],
    //   descripcion: [null, Validators.required],
    //   tipo: [null, Validators.required],
    //   visibilidad: [null, Validators.required],
    //   carga: [null, Validators.required],
    //   estado: [null, Validators.required],
    // });
    this.form=this.fb.group({
      codigo: [this.selectedServicio.codigo || '', Validators.required],
      nombre: [this.selectedServicio.nombre || null, Validators.required],
      descripcion: [this.selectedServicio.descripcion || null, Validators.required],
      tipo: [this.selectedServicio.tipo || null, Validators.required],
      visibilidad: [this.selectedServicio.visibilidad || null, Validators.required],
      carga: [this.selectedServicio.carga || null, Validators.required],
      estado: [this.selectedServicio.estado || null, Validators.required],
    });
  }

  // add save method
  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedServicio.id
      ? this.servicioService.update(this.selectedServicio.id,this.form.value)
      : this.servicioService.create(this.form.value);

    request.subscribe(()=>{
      this.isModalOpen=false;
      this.form.reset();
      this.list.get();
    });
    // this.servicioService.create(this.form.value).subscribe(() => {
    //   this.isModalOpen = false;
    //   this.form.reset();
    //   this.list.get();
    // });
  }
}

