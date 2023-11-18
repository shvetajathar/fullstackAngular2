import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListmoviesComponent } from './listmovies/listmovies.component';
import { FormsModule,NgForm } from '@angular/forms';
import { AddmovieComponent } from './addmovie/addmovie.component';
import { MenuComponent } from './menu/menu.component';
// import { ReactiveFormsModule } from '@angular/forms';
@NgModule({
  declarations: [
    AppComponent,
    ListmoviesComponent,
    AddmovieComponent,
    MenuComponent
    // ReactiveFormsModule
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    // ReactiveFormsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
