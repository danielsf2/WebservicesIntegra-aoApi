package com.webservice.api.models;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;

@Entity(name = "turma")
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Turma {

    @Id
    @GeneratedValue
    private Integer id;

    @Column(name = "ano")
    private Integer Ano;

    @Column(name = "curso")
    private String Curso;


}//class Turma
