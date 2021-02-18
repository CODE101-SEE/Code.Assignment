export interface ILightSaber {
    id: string;
    color: string;
    width: number;
    length: number;
    attack: number;
    defense: number;
    type: number;
    jediId: string;
}

export interface IJedi {
    id: string;
    name: string;
    surname: string;
    title: string;
    birthDate: Date;
    height: number;
    width: number;
    weight: number;
    lightSaber: ILightSaber;
    midiChlorianCount: number;
}

