package com.webservice.api.models;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.NoArgsConstructor;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;

@Entity(name = "aluno")
@NoArgsConstructor
@AllArgsConstructor
@Builder
public class Aluno {

    @Id
    private Integer id_aluno;

    @Column
    private Integer id_turma;

    @Column
    private String nome;

    @Column
    private Boolean matriculado;

}//class Aluno
