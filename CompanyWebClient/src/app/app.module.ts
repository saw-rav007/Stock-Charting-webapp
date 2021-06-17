import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule} from "@angular/forms";
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { CompanyDetailsComponent } from './company-details/company-details.component';
import { CompanyDetailFormComponent } from './company-details/company-detail-form/company-detail-form.component';
import {  HttpClientModule } from '@angular/common/http';
import { UserNavBarComponent } from './navbar/user-nav-bar/user-nav-bar.component';
import { AdminNavBarComponent } from './navbar/admin-nav-bar/admin-nav-bar.component';
import { AppRoutingModule } from './app-routing.module';
import { AuthenticationComponent } from './authentication/authentication.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    CompanyDetailsComponent,
    CompanyDetailFormComponent,
    UserNavBarComponent,
    AdminNavBarComponent,
    AuthenticationComponent,
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), AppRoutingModule,  // ToastrModule added
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
