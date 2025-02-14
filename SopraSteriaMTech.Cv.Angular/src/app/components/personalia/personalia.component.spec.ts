import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonaliaComponent } from './personalia.component';

describe('PersonaliaComponent', () => {
  let component: PersonaliaComponent;
  let fixture: ComponentFixture<PersonaliaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [PersonaliaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PersonaliaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
