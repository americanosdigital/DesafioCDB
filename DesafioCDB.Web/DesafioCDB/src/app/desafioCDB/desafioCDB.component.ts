import { FormArray, FormControl, FormGroup, RequiredValidator, Validators,ReactiveFormsModule } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { DesafioCDBServico } from 'src/app/shared/servicos/DesafioCDBServico.service';
import { IDesafioCalculoCDBResponse } from '../shared/Interfaces/IDesafioCalculoCDBResponse';

@Component({
  selector: 'app-desafioCDB',
  templateUrl: './desafioCDB.component.html',
  styleUrls: ['./desafioCDB.component.css']
})
export class DesafioCDBComponent implements OnInit {

  formGroup: FormGroup

  valorInicial: number = 0;
  valorFinal: number = 0;

  constructor(private desafioCDBService: DesafioCDBServico) { }

  ngOnInit(): void {
    this.formGroup = new FormGroup({
      valor: new FormControl(null, [Validators.required,Validators.min(1)]),
      qtdMeses: new FormControl(null, [Validators.required,Validators.min(1)]),
    });
  }

  onSubmit(formData: any) {
    this.desafioCDBService.FazerCalculoCDB(formData).subscribe((resposta: IDesafioCalculoCDBResponse) => {
      this.valorInicial = resposta.valorInicial;
      this.valorFinal = resposta.valorFinal;
    });
    
  }
}
