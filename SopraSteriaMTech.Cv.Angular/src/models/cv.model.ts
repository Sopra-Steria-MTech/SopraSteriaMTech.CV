import { Cursus } from "./cursus.model";
import { Ervaring } from "./ervaring.model";
import { Kennis } from "./kennis.model";
import { Opleiding } from "./opleiding.model";
import { Personalia } from "./personalia.model";
import { Taal } from "./taal.model";

export class Cv {
    id: number = -1;
    personalia: Personalia | null = null;
    opleidingen: Opleiding[] = [];
    cursussen: Cursus[] = [];
    werkervaring: Ervaring[] = [];
    talen: Taal[] = [];
    kennis: Kennis[] = [];
}