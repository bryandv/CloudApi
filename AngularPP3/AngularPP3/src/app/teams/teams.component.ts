import { Component, OnInit } from '@angular/core';
import {Teams,ApiPPService} from "../service/api-pp.service";

@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrls: ['./teams.component.css'],
})
export class TeamsComponent implements OnInit {
teams: Teams;
  constructor(private _svc: ApiPPService) { }

  ngOnInit() {
    this._svc.getTeams().subscribe(result => this.teams = result);
  }

}
