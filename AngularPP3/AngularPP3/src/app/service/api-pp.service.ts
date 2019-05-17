import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiPPService {

  constructor(private _http:HttpClient) { }

  getTeams(): Observable<Teams>{
    return this._http.get<Teams>("http://localhost:55747/api/pp/lijst");
  }
}

export interface Speler1 {
  naam: string;
  klassement: string;
  club: string;
}

export interface Speler2 {
  naam: string;
  klassement: string;
  club: string;
}

export interface Teams{
  speler1: Speler1;
  speler2: Speler2;
  totaalwaarde: number;
}