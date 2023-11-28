import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DesafioCDBServicoEnum } from '../Enums/DesafioCDBServicoEnum';
import { environment } from 'src/environments/environment';
import { IDesafioCalculoCDB } from '../Interfaces/IDesafioCalculoCDB';

@Injectable({
  providedIn: 'root'
})
export class DesafioCDBServico {

  private readonly url: string; 

  constructor(private httpClient: HttpClient) {
    this.url = environment.backendUrlApi
  }

  public FazerCalculoCDB(desafioCalculoCDB: IDesafioCalculoCDB): Observable<any> {
    return this.httpClient.get(this.url + DesafioCDBServicoEnum.CalcularCDB + "/" + desafioCalculoCDB.valor + "/" + desafioCalculoCDB.qtdMeses
    );
  }

}
