import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http'; 
import { AppComponent } from './app.component';
import {RouterModule} from '@angular/router'
import {ButtonModule} from 'primeng/button';
import {TableModule} from 'primeng/table';
import {TabMenuModule} from 'primeng/tabmenu';
import {ToolbarModule} from 'primeng/toolbar';
import {CardModule} from 'primeng/card';
import {PanelModule} from 'primeng/panel';
import {InputTextModule} from 'primeng/inputtext';
import {FormsModule} from '@angular/forms'
import { TeamsComponent } from './teams/teams.component';
import { SwapiComponent } from './swapi/swapi.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';


@NgModule({
  declarations: [
    AppComponent,
    TeamsComponent,
    SwapiComponent,
    NavbarComponent,
    HomeComponent,
    
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    ButtonModule,
    TableModule,
    TabMenuModule,
    FormsModule,
    CardModule,
    InputTextModule,
    PanelModule,
    ToolbarModule,
    RouterModule.forRoot([
      { path: "", redirectTo: "home", pathMatch: "full"},
      {path: "home",component:HomeComponent},
      {path: "star",component:SwapiComponent},
      {path: "pp",component:TeamsComponent}
    ])
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
