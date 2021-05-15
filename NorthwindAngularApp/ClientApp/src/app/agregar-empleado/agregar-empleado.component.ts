import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from "@angular/router";
import { environment } from "../../environments/environment";

@Component({
  selector: 'app-agregar-empleado',
  templateUrl: './agregar-empleado.component.html',
  styleUrls: ['./agregar-empleado.component.css']
})
export class AgregarEmpleadoComponent implements OnInit {

  private baseURL = location.origin;
  profileForm: FormGroup;

  constructor(private http: HttpClient) { }

  ngOnInit() {
      this.profileForm  = new FormGroup({
      nombre: new FormControl(null, {
        validators: [Validators.required]
      }),
      apellido: new FormControl(null, {
        validators: [Validators.required]
      }),
      pais: new FormControl(null, {
        validators: [Validators.required]
      }),
      direccion: new FormControl(null, {
        validators: [Validators.required]
      }),
    });
  }

  onSubmit(){
    this.http.post<Employee>(environment.ApiConfig.url, {
      "nombre": this.profileForm.value.nombre,
      "apellido": this.profileForm.value.apellido,
      "pais": this.profileForm.value.pais,
      "direccion": this.profileForm.value.direccion
    }).subscribe(employee => console.log('Employee successful'));
    this.profileForm.reset();
  }
}

export class Employee {
  constructor(
    public nombre: string,
    public apellido: string,
    public pais: string,
    public direccion: string,
  ) {}
}
