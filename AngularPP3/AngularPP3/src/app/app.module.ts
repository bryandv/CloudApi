import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http'; 
import { AppComponent } from './app.component';

import {ButtonModule} from 'primeng/button';
import {TableModule} from 'primeng/table';
import { TeamsComponent } from './teams/teams.component';


@NgModule({
  declarations: [
    AppComponent,
    TeamsComponent,
    
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    ButtonModule,
    TableModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
