import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from "@angular/router";
import { environment } from "../../environments/environment";

@Component({
  selector: 'app-eliminar-empleado',
  templateUrl: './eliminar-empleado.component.html',
  styleUrls: ['./eliminar-empleado.component.css']
})
export class EliminarEmpleadoComponent implements OnInit {

  deleteForm: FormGroup;
  private urlApi: string;

  constructor(private http: HttpClient) { }

  ngOnInit() {
      this.deleteForm  = new FormGroup({
        id: new FormControl(null)
    });
  }

  onSubmit() {
    console.log(this.deleteForm.value.id);
    this.urlApi = `${environment.ApiConfig.url}/${this.deleteForm.value.id}`;
    this.http.delete(this.urlApi)
    .subscribe(() =>  console.log('Delete successful'));
    this.deleteForm.reset();
  }

}
