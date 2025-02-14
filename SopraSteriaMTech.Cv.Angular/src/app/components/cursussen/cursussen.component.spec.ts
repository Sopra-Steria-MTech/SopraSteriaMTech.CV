import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CursussenComponent } from './cursussen.component';

describe('CursussenComponent', () => {
  let component: CursussenComponent;
  let fixture: ComponentFixture<CursussenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CursussenComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CursussenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
