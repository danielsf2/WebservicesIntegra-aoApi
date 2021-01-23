package com.webservice.api.models;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

@Entity(name = "aluno")
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Aluno {

    @Id
    @GeneratedValue
    private Integer id_aluno;

    @Column(name = "id_turma")
    private Integer id_turma;

    @Column(name = "nome")
    private String nome;

    @Column(name = "matriculado")
    private Boolean matriculado;

}//class Aluno
