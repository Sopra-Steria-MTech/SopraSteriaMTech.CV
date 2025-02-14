import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PersonaliaComponent } from './components/personalia/personalia.component';
import { OpleidingenComponent } from './components/opleidingen/opleidingen.component';
import { CursussenComponent } from './components/cursussen/cursussen.component';
import { WerkervaringComponent } from './components/werkervaring/werkervaring.component';
import { KennisComponent } from './components/kennis/kennis.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { UploadImageComponent } from './components/upload-image/upload-image.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    PersonaliaComponent,
    OpleidingenComponent,
    CursussenComponent,
    WerkervaringComponent,
    KennisComponent,
    NavMenuComponent,
    UploadImageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
