import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OpleidingenComponent } from './opleidingen.component';

describe('OpleidingenComponent', () => {
  let component: OpleidingenComponent;
  let fixture: ComponentFixture<OpleidingenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [OpleidingenComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(OpleidingenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
